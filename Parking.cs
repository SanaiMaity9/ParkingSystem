using System;

namespace ParkingSystem
{
    public class Parking{
        int NoOfSpace = 200;
        
        public String ParkingSpace(){
            if(NoOfSpace != 0){
                NoOfSpace -= 1;
                return "Yes";
            }
            else{
                return "No";
            }
        }
        public void FreeParkingSpace(){
           if(NoOfSpace <= 200){
                NoOfSpace += 1;
            }
        } 
    }  
}