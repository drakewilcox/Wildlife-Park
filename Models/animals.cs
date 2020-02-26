namespace ParkAnimals.Models
{

  public class Animals
  {
    private string _animalType;
    private int _animalAmount;
    private string _safe;

    public Animals(string animalType, int animalAmount, string safe)
    {
      _animalType = animalType;
      _animalAmount = animalAmount;
      _safe = safe;
    }
    public string GetAnimalType()
    {
      return _animalType;
    }
    public int GetAnimalAmount()
    {
      return _animalAmount;
    }
    public string GetSafe()
    {
      return _safe;
    }
    // public static void SetAnimalType(string newAnimalType)
    // {
    //   _animalType = newAnimalType;
    // }
    // public void SetAnimalAmount(int newAnimalAmount)
    // {
    //   _animalAmount = newAnimalAmount;
    // }
    // public void SetAnimalSafe(string newAnimalSafe)
    // {
    //   _safe = newAnimalSafe;
    // }

  }
}