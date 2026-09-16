class Person
{
    private string name;
    private int numberOfChildren;

    public string Name
    {

        get
        {
            return name;
        }

        set
        {
            if (value.Length == 0) throw new Exception("ADJ NEKI NEVET BASZOD!!!!!");
            if (value == "Fasz") throw new Exception("SZÁPEN BESZÉLJÉL A KURVA ANYÁDAT!");

            name = value;
        }
    }
    //public int NumberOfChildren { get => numberOfChildren; set => numberOfChildren = value; }

}