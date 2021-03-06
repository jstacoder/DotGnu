/*
 * SecurityPermission.cs - Implementation of the
 *		"System.Security.Permissions.SecurityPermission" class.
 *
 * Copyright (C) 2001, 2003  Southern Storm Software, Pty Ltd.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace System.Security.Permissions
{

#if CONFIG_PERMISSIONS

using System;
using System.Security;

public sealed class SecurityPermission
	: CodeAccessPermission, IUnrestrictedPermission
{
	// Internal state.
	private PermissionState state;
	private SecurityPermissionFlag flags;

	// Constructor.
	public SecurityPermission(PermissionState state)
			{
				this.state = state;
			}
	public SecurityPermission(SecurityPermissionFlag flags)
			{
				this.flags = flags;
			}

	// Convert an XML value into a permissions value.
	public override void FromXml(SecurityElement esd)
			{
				String value;
				if(esd == null)
				{
					throw new ArgumentNullException("esd");
				}
				if(esd.Attribute("version") != "1")
				{
					throw new ArgumentException(_("Arg_PermissionVersion"));
				}
				value = esd.Attribute("Unrestricted");
				if(value != null && Boolean.Parse(value))
				{
					state = PermissionState.Unrestricted;
				}
				else
				{
					state = PermissionState.None;
				}
				value = esd.Attribute("Flags");
				if(value != null)
				{
					flags = (SecurityPermissionFlag)
						Enum.Parse(typeof(SecurityPermissionFlag), value);
				}
				else
				{
					flags = SecurityPermissionFlag.NoFlags;
				}
			}

	// Convert this permissions object into an XML value.
	public override SecurityElement ToXml()
			{
				SecurityElement element;
				element = new SecurityElement("IPermission");
				element.AddAttribute
					("class",
					 SecurityElement.Escape(typeof(SecurityPermission).
					 						AssemblyQualifiedName));
				element.AddAttribute("version", "1");
				if(flags != SecurityPermissionFlag.NoFlags)
				{
					element.AddAttribute("Flags", flags.ToString());
				}
				else if(state == PermissionState.Unrestricted)
				{
					element.AddAttribute("Unrestricted", "true");
				}
				return element;
			}

	// Implement the IPermission interface.
	public override IPermission Copy()
			{
				if(flags != SecurityPermissionFlag.NoFlags)
				{
					return new SecurityPermission(flags);
				}
				else
				{
					return new SecurityPermission(state);
				}
			}
	public override IPermission Intersect(IPermission target)
			{
				SecurityPermissionFlag newFlags;
				if(target == null)
				{
					return target;
				}
				else if(!(target is SecurityPermission))
				{
					throw new ArgumentException(_("Arg_PermissionMismatch"));
				}
				else if(((SecurityPermission)target).IsUnrestricted())
				{
					if(IsUnrestricted())
					{
						return Copy();
					}
					else
					{
						newFlags = flags;
					}
				}
				else if(IsUnrestricted())
				{
					newFlags = ((SecurityPermission)target).flags;
				}
				else
				{
					newFlags = ((SecurityPermission)target).flags & flags;
				}
				if(newFlags == 0)
				{
					return null;
				}
				else
				{
					return new SecurityPermission(newFlags);
				}
			}
	public override bool IsSubsetOf(IPermission target)
			{
				if(target == null)
				{
					return (flags == SecurityPermissionFlag.NoFlags);
				}
				else if(!(target is SecurityPermission))
				{
					throw new ArgumentException(_("Arg_PermissionMismatch"));
				}
				else if(((SecurityPermission)target).IsUnrestricted())
				{
					return true;
				}
				else if(IsUnrestricted())
				{
					return false;
				}
				else
				{
					return ((flags & ~(((SecurityPermission)target).flags))
								== 0);
				}
			}
	public override IPermission Union(IPermission target)
			{
				if(target == null)
				{
					return Copy();
				}
				else if(!(target is SecurityPermission))
				{
					throw new ArgumentException(_("Arg_PermissionMismatch"));
				}
				else if(IsUnrestricted() ||
				        ((SecurityPermission)target).IsUnrestricted())
				{
					return new SecurityPermission
						(PermissionState.Unrestricted);
				}
				else
				{
					return new SecurityPermission
						(flags | ((SecurityPermission)target).flags);
				}
			}

	// Determine if this object has unrestricted permissions.
#if ECMA_COMPAT
	private bool IsUnrestricted()
			{
				return (state == PermissionState.Unrestricted);
			}
	bool IUnrestrictedPermission.IsUnrestricted()
#else
	public bool IsUnrestricted()
#endif
			{
				return (state == PermissionState.Unrestricted);
			}

#if !ECMA_COMPAT

	// Get or set the flags on this permissions object.
	public SecurityPermissionFlag Flags
			{
				get
				{
					return flags;
				}
				set
				{
					if((flags & ~(SecurityPermissionFlag.AllFlags)) != 0)
					{
						throw new ArgumentException(_("Arg_SecurityFlag"));
					}
				}
			}

#endif // !ECMA_COMPAT

}; // class SecurityPermission

#endif // CONFIG_PERMISSIONS

}; // namespace System.Security.Permissions
