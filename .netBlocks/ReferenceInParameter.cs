namespace TestPassByValueForObects
{
    //ObjectRef obRef = new ObjectRef();
    //obRef.ChangeByValTest = 50;
    //Console.WriteLine(obRef.ChangeByValTest);//50
    //ObjectRef.ChangeValue(obRef,100);
    //Console.WriteLine(obRef.ChangeByValTest);//100
    //ObjectRef.ChangeValueByReferenceIncreaseBy10(ref obRef, 121);
    //Console.WriteLine(obRef.ChangeByValTest);//131

   Default Mathod Invokation=> Call by value
   Change in value test using the call by value and call by Reference
    public class ObjectRef
    {
        public int ChangeByValTest { get; set; }

        internal static void ChangeValue(ObjectRef obRef,int v)
        {
            obRef.ChangeByValTest = v;
        }

        internal static void ChangeValueByReferenceIncreaseBy10(ref ObjectRef obRef, int v)
        {
            obRef.ChangeByValTest = v;
            obRef = new ObjectRef();
            obRef.ChangeByValTest = v + 10;
        }
    }
}
