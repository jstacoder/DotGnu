/*
 * CodeGotoStatement.cs - Implementation of the
 *		System.CodeDom.CodeGotoStatement class.
 *
 * Copyright (C) 2002, 2003  Southern Storm Software, Pty Ltd.
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

namespace System.CodeDom
{

#if CONFIG_CODEDOM

using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Specialized;

[Serializable]
#if CONFIG_COM_INTEROP
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
#endif
public class CodeGotoStatement : CodeStatement
{

	// Internal state.
	private String _Label;

	// Constructors.
	public CodeGotoStatement(String _Label)
			{
				this._Label = _Label;
			}

	// Properties.
	public String Label
			{
				get
				{
					return _Label;
				}
				set
				{
					_Label = value;
				}
			}

}; // class CodeGotoStatement

#endif // CONFIG_CODEDOM

}; // namespace System.CodeDom
