using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #region Adding values to ArrayList
            string[] arr = new string[2];
            string[] arr2 = new string[]
            {
                "One",
                "Two"
            };

            ArrayList ArrList = new ArrayList();

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();
            students.Add("Samir");
            students.Add("Javid");
            students.Add("Orxan");
            students.Add("Teymur");
            students.Add("Gunay");
            students.Add("Zaur");

            capacity = students.Capacity;
            count = students.Count;

            students.Add(5);
            students.Add(true);
            #endregion



            #region Adding Collection to ArrayList
            //A1 sinifi
            ArrayList A1 = new ArrayList();
            A1.Add("Samir");
            A1.Add("Javid");
            A1.Add("Orxan");

            //A2 sinifi
            ArrayList A2 = new ArrayList();
            A2.Add("Teymur");
            A2.Add("Gunay");
            A2.Add("Zaur");

            A1.AddRange(A2); //A2'ni A1'e elave edir
            #endregion



            #region Getting values from ArrayList
            var orxan = A1[2]; //object tipindedir
            object objGunay = A1[4];
            string strGunay = A1[4].ToString();

            ArrayList mixArray = new ArrayList();
            mixArray.Add("string value");
            mixArray.Add(1);
            mixArray.Add(5.5F);
            mixArray.Add('C');
            mixArray.Add(1.2D);
            mixArray.Add(true);

            var strVal = mixArray[0].ToString();
            var numVal = (int)mixArray[1];
            var floatVal = (float)mixArray[2];
            var charVal = (char)mixArray[3];
            var doubleVal = (double)mixArray[4];
            var boolVal = (bool)mixArray[5];
            #endregion


            #region Sorting values in ArrayList
            //Ters siralama
            A1.Reverse();

            //A-Z siralama
            A1.Sort();
            #endregion


            #region Checking if value exists
            A1.Add("Malik");

            bool ct = A1.Contains("Malik");

            if (A1.Contains("Malik"))
            {
                int indexOfName = A1.IndexOf("Malik");
                A1.RemoveAt(indexOfName);
            }
            #endregion



            #region Clearing (TrimToSize) Array
            var capacityOfA1 = A1.Capacity;
            var countOfA1 = A1.Count;
            A1.Add("Malik");
            A1.Clear();
            A1.TrimToSize();
            #endregion
            #endregion
        }
    }
}
