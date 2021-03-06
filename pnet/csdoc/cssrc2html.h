
/*
 * cssrc2html.h - C# source file to HTML translator
 *
 * Copyright (C) 2003  Southern Storm Software, Pty Ltd.
 *
 * Author: Jeff Post
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 *
 */

#ifndef	FALSE
#define	FALSE	0
#endif
#ifndef	TRUE
#define	TRUE	1
#endif

#define	VERSION		0
#define	REV_MAJOR	0
#define	REV_MINOR	3

#define	bool		int

#define	MAX_LENGTH		128	// maximum string & token length

extern char		lineBuffer[MAX_LENGTH];

// end of file
