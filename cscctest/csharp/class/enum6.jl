.assembly extern '.library'
{
	.ver 0:0:0:0
}
.assembly '<Assembly>'
{
	.ver 0:0:0:0
}
.module '<Module>'
.namespace 'ns1'
{
.class private auto sealed serializable ansi 'Foo' extends ['.library']'System'.'Enum'
{
.field public static literal valuetype 'ns1'.'Foo' 'X' = int32(0x00000000)
.field public static literal valuetype 'ns1'.'Foo' 'Y' = int32(0x00000001)
.field public specialname rtspecialname int32 'value__'
} // class Foo
} // namespace ns1
.namespace 'ns1'
{
.class public auto ansi 'FooBar' extends ['.library']'System'.'Object'
{
.method public static hidebysig void 'WriteLine'(class ['.library']'System'.'Object' 'o') cil managed java 
{
	return
	.locals 1
	.maxstack 0
} // method WriteLine
.method public static hidebysig void 'Main'() cil managed java 
{
	iconst_0
	invokestatic	"ns1/Foo" "copyIn__" "(I)Lns1/Foo;"
	invokestatic	void 'ns1'.'FooBar'::'WriteLine'(class ['.library']'System'.'Object')
	return
	.locals 0
	.maxstack 1
} // method Main
.method assembly hidebysig specialname instance valuetype 'ns1'.'Foo' 'get_Foo'() cil managed java 
{
	iconst_1
	ireturn
	.locals 1
	.maxstack 1
} // method get_Foo
.property valuetype 'ns1'.'Foo' 'Foo'()
{
	.get instance valuetype 'ns1'.'Foo' 'ns1'.'FooBar'::'get_Foo'()
} // property Foo
.method public hidebysig specialname rtspecialname instance void '.ctor'() cil managed java 
{
	aload_0
	invokespecial	instance void ['.library']'System'.'Object'::'.ctor'()
	return
	.locals 1
	.maxstack 1
} // method .ctor
} // class FooBar
} // namespace ns1
