using System;

namespace Virtual_Methods
{
    public class Item : BaseClass
    {
        #region Create and use virtual methods
        public override void ShowText(string text)
        {
            base.ShowText(text);
            Console.WriteLine("Item => " + text);
        }
        #endregion
    }
}
