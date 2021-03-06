/*
 * InstallInProgressException.cs - Implementation of the
 *		"System.Deployment.InstallInProgressException" class.
 *
 * Copyright (C) 2004  Southern Storm Software, Pty Ltd.
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

namespace System.Deployment
{

using System;
using System.Runtime.Serialization;

public class InstallInProgressException : DeploymentException
{
	// Constructors.
	public InstallInProgressException()
		: base(S._("SD_InstallInProgress")) {}
	public InstallInProgressException(String message)
		: base(message) {}
	public InstallInProgressException
			(String message, Exception innerException)
		: base(message, innerException) {}

#if CONFIG_SERIALIZATION

	// De-serialize this object.
	protected InstallInProgressException
			(SerializationInfo info, StreamingContext context)
		: base(info, context) {}

#endif // CONFIG_SERIALIZATION

}; // class InstallInProgressException

}; // namespace System.Deployment
