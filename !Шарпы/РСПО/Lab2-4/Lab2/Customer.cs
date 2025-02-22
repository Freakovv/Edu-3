public class Customer
{
    public string Code { get; }
    public string FullName { get; }
    public string ContactPhone { get; }
    public bool Privileged { get; }

    public Customer(string code, string fullName, string contactPhone, bool privileged)
    {
        Code = code;
        FullName = fullName;
        ContactPhone = contactPhone;
        Privileged = privileged;
    }
}