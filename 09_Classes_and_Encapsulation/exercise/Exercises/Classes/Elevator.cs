using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Exercises.Classes
{
    public class Elevator
    {
        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }

        public Elevator (int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }
        
        public void OpenDoor()
        {
            DoorIsOpen = true;
        }
       public void CloseDoor()
        {
            DoorIsOpen = false;
        }
        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && desiredFloor > CurrentLevel && CurrentLevel < NumberOfLevels)
            {
                CurrentLevel++;
                return;
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && desiredFloor < CurrentLevel && CurrentLevel > 1)
            {
                CurrentLevel--;
                return;
            }
        }

        }
    }

