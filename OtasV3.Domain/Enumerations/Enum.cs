namespace OtasV3.Domain.Enumerations
{
    public enum Gender
    {
        Unspecified = 0,
        Male = 1,
        Female = 2,
        Other = 3
    }

    /// <summary>
    /// This is a title prefixing a person's name
    /// </summary>
    /// 
    public enum Honorific
    {
        Ms = 1,
        Mr = 2,
        Mrs = 3,
        Dr = 4,
        Other = 5,

        //YourHighness = 6 ;)
    }
}