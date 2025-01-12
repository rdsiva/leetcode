public class ParkingSystem
{

    public int[] spacesLeft;
    public int medium = 0;
    public int small = 0;
    public ParkingSystem(int big, int medium, int small)
    {
        spacesLeft = new int[3] { big, medium, small };
    }

    public bool AddCar(int carType)
    {
        if (spacesLeft[carType - 1] > 0)
        {
            spacesLeft[carType - 1]--;
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