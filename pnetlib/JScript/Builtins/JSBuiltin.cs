/*
 * JSBuiltin.cs - Codes for builtin methods.
 *
 * Copyright (C) 2003 Southern Storm Software, Pty Ltd.
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
 
namespace Microsoft.JScript
{

public enum JSBuiltin
{
	Array_concat					=   1,
	Array_join						=   2,
	Array_pop						=   3,
	Array_push						=   4,
	Array_reverse					=   5,
	Array_shift						=   6,
	Array_slice						=   7,
	Array_sort						=   8,
	Array_splice					=   9,
	Array_toLocaleString			=  10,
	Array_toString					=  11,
	Array_unshift					=  12,
	Boolean_toString				=  13,
	Boolean_valueOf					=  14,
	Date_getDate					=  15,
	Date_getDay						=  16,
	Date_getFullYear				=  17,
	Date_getHours					=  18,
	Date_getMilliseconds			=  19,
	Date_getMinutes					=  20,
	Date_getMonth					=  21,
	Date_getSeconds					=  22,
	Date_getTime					=  23,
	Date_getTimezoneOffset			=  24,
	Date_getUTCDate					=  25,
	Date_getUTCDay					=  26,
	Date_getUTCFullYear				=  27,
	Date_getUTCHours				=  28,
	Date_getUTCMilliseconds			=  29,
	Date_getUTCMinutes				=  30,
	Date_getUTCMonth				=  31,
	Date_getUTCSeconds				=  32,
	Date_getVarDate					=  33,
	Date_getYear					=  34,
	Date_parse						=  35,
	Date_setDate					=  36,
	Date_setFullYear				=  37,
	Date_setHours					=  38,
	Date_setMinutes					=  39,
	Date_setMilliseconds			=  40,
	Date_setMonth					=  41,
	Date_setSeconds					=  42,
	Date_setTime					=  43,
	Date_setUTCDate					=  44,
	Date_setUTCFullYear				=  45,
	Date_setUTCHours				=  46,
	Date_setUTCMinutes				=  47,
	Date_setUTCMilliseconds			=  48,
	Date_setUTCMonth				=  49,
	Date_setUTCSeconds				=  50,
	Date_setYear					=  51,
	Date_toDateString				=  52,
	Date_toGMTString				=  53,
	Date_toLocaleDateString			=  54,
	Date_toLocaleString				=  55,
	Date_toLocaleTimeString			=  56,
	Date_toString					=  57,
	Date_toTimeString				=  58,
	Date_toUTCString				=  59,
	Date_UTC						=  60,
	Date_valueOf					=  61,
	Enumerator_atEnd				=  62,
	Enumerator_item					=  63,
	Enumerator_moveFirst			=  64,
	Enumerator_moveNext				=  65,
	Error_toString					=  66,
	Function_apply					=  67,
	Function_call					=  68,
	Function_toString				=  69,
	Global_CollectGarbage			=  70,
	Global_decodeURI				=  71,
	Global_decodeURIComponent		=  72,
	Global_encodeURI				=  73,
	Global_encodeURIComponent		=  74,
	Global_escape					=  75,
	Global_eval						=  76,
	Global_GetObject				=  77,
	Global_isNaN					=  78,
	Global_isFinite					=  79,
	Global_parseFloat				=  80,
	Global_parseInt					=  81,
	Global_ScriptEngine				=  82,
	Global_ScriptEngineBuildVersion	=  83,
	Global_ScriptEngineMajorVersion	=  84,
	Global_ScriptEngineMinorVersion	=  85,
	Global_unescape					=  86,
	Math_abs						=  87,
	Math_acos						=  88,
	Math_asin						=  89,
	Math_atan						=  90,
	Math_atan2						=  91,
	Math_ceil						=  92,
	Math_cos						=  93,
	Math_exp						=  94,
	Math_floor						=  95,
	Math_log						=  96,
	Math_max						=  97,
	Math_min						=  98,
	Math_pow						=  99,
	Math_random						= 100,
	Math_round						= 101,
	Math_sin						= 102,
	Math_sqrt						= 103,
	Math_tan						= 104,
	Number_toExponential			= 105,
	Number_toFixed					= 106,
	Number_toLocaleString			= 107,
	Number_toPrecision				= 108,
	Number_toString					= 109,
	Number_valueOf					= 110,
	Object_hasOwnProperty			= 111,
	Object_isPrototypeOf			= 112,
	Object_propertyIsEnumerable		= 113,
	Object_toLocaleString			= 114,
	Object_toString					= 115,
	Object_valueOf					= 116,
	RegExp_compile					= 117,
	RegExp_exec						= 118,
	RegExp_test						= 119,
	RegExp_toString					= 120,
	String_anchor					= 121,
	String_big						= 122,
	String_blink					= 123,
	String_bold						= 124,
	String_charAt					= 125,
	String_charCodeAt				= 126,
	String_concat					= 127,
	String_fixed					= 128,
	String_fontcolor				= 129,
	String_fontsize					= 130,
	String_fromCharCode				= 131,
	String_indexOf					= 132,
	String_italics					= 133,
	String_lastIndexOf				= 134,
	String_link						= 135,
	String_localeCompare			= 136,
	String_match					= 137,
	String_replace					= 138,
	String_search					= 139,
	String_slice					= 140,
	String_small					= 141,
	String_split					= 142,
	String_strike					= 143,
	String_sub						= 144,
	String_substr					= 145,
	String_substring				= 146,
	String_sup						= 147,
	String_toLocaleLowerCase		= 148,
	String_toLocaleUpperCase		= 149,
	String_toLowerCase				= 150,
	String_toString					= 151,
	String_toUpperCase				= 152,
	String_valueOf					= 153,
	VBArray_dimensions				= 154,
	VBArray_getItem					= 155,
	VBArray_lbound					= 156,
	VBArray_toArray					= 157,
	VBArray_ubound					= 158

}; // enum JSBuiltin

}; // namespace Microsoft.JScript
