public class ParkingSystem {
    int[] slots;
    public ParkingSystem(int big, int medium, int small) {
        slots = new int[]{big,medium,small};
    }
    
    public bool AddCar(int carType) {
         if(slots[carType -1 ]>0){
            slots[carType-1]--;
            return true;
         }

         return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */