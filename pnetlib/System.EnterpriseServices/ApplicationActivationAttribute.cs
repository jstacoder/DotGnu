/*
 * ApplicationActivationAttribute.cs - Implementation of the
 *		"System.EnterpriseServices.ApplicationActivationAttribute" class.
 *
 * Copyright (C) 2003  Southern Storm Software, Pty Ltd.
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

namespace System.EnterpriseServices
{

using System.Runtime.InteropServices;

#if !ECMA_COMPAT
[ComVisible(false)]
#endif
[AttributeUsage(AttributeTargets.Assembly, Inherited=true)]
public sealed class ApplicationActivationAttribute : Attribute
{
	// Internal state.
	private ActivationOption opt;
	private String soapMailbox;
	private String soapVRoot;

	// Constructor.
	public ApplicationActivationAttribute(ActivationOption opt)
			{
				this.opt = opt;
			}

	// Get or set this attribute's values.
	public String SoapMailbox
			{
				get
				{
					return soapMailbox;
				}
				set
				{
					soapMailbox = value;
				}
			}
	public String SoapVRoot
			{
				get
				{
					return soapVRoot;
				}
				set
				{
					soapVRoot = value;
				}
			}
	public ActivationOption Value
			{
				get
				{
					return opt;
				}
			}

}; // class ApplicationActivationAttribute

}; // namespace System.EnterpriseServices
