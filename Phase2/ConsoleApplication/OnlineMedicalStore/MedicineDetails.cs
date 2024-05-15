using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        private static int s_medicineID = 2000;
        public string MedicineID { get; set; }
        public string MedinceName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medinceName,int availableCount,double price,DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID = "MD" + s_medicineID;
            MedinceName = medinceName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        public MedicineDetails(string medince)
        {
            string[] value = medince.Split(",");
            s_medicineID = int.Parse(value[0].Remove(0,2));
            MedicineID = value[0];
            MedinceName = value[1];
            AvailableCount = int.Parse(value[2]);
            Price = int.Parse(value[3]);
            DateOfExpiry = DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
        }
    }
}