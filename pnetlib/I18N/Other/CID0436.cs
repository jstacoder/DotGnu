/*
 * CID0436.cs - af-ZA culture handler.
 *
 * Copyright (c) 2003  Southern Storm Software, Pty Ltd
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

// Generated from "af_ZA.txt".

namespace I18N.Other
{

using System;
using System.Globalization;
using I18N.Common;

public class CID0436 : CID0036
{
	public CID0436() : base(0x0436) {}

	public override String Name
	{
		get
		{
			return "af-ZA";
		}
	}
	public override String Country
	{
		get
		{
			return "ZA";
		}
	}

	public override DateTimeFormatInfo DateTimeFormat
	{
		get
		{
			DateTimeFormatInfo dfi = base.DateTimeFormat;
			dfi.DateSeparator = "/";
			dfi.TimeSeparator = ":";
			dfi.LongDatePattern = "dd MMMM yyyy";
			dfi.LongTimePattern = "h:mm:ss tt";
			dfi.ShortDatePattern = "yyyy/MM/dd";
			dfi.ShortTimePattern = "h:mm tt";
			dfi.FullDateTimePattern = "dddd dd MMMM yyyy h:mm:ss tt";
			dfi.I18NSetDateTimePatterns(new String[] {
				"d:yyyy/MM/dd",
				"D:dddd dd MMMM yyyy",
				"f:dddd dd MMMM yyyy h:mm:ss tt",
				"f:dddd dd MMMM yyyy h:mm:ss tt",
				"f:dddd dd MMMM yyyy h:mm:ss tt",
				"f:dddd dd MMMM yyyy h:mm tt",
				"F:dddd dd MMMM yyyy HH:mm:ss",
				"g:yyyy/MM/dd h:mm:ss tt",
				"g:yyyy/MM/dd h:mm:ss tt",
				"g:yyyy/MM/dd h:mm:ss tt",
				"g:yyyy/MM/dd h:mm tt",
				"G:yyyy/MM/dd HH:mm:ss",
				"m:MMMM dd",
				"M:MMMM dd",
				"r:ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
				"R:ddd, dd MMM yyyy HH':'mm':'ss 'GMT'",
				"s:yyyy'-'MM'-'dd'T'HH':'mm':'ss",
				"t:h:mm:ss tt",
				"t:h:mm:ss tt",
				"t:h:mm:ss tt",
				"t:h:mm tt",
				"T:HH:mm:ss",
				"u:yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
				"U:dddd, dd MMMM yyyy HH:mm:ss",
				"y:yyyy MMMM",
				"Y:yyyy MMMM",
			});
			return dfi;
		}
		set
		{
			base.DateTimeFormat = value; // not used
		}
	}

}; // class CID0436

public class CNaf_za : CID0436
{
	public CNaf_za() : base() {}

}; // class CNaf_za

}; // namespace I18N.Other
