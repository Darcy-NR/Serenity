namespace Serenity
{
    public class User
    {
        public string receiptID;
        public string password;
        public string email;

        // Default constructor //
        public User(string receiptID, string password, string email)
        {
            this.receiptID = receiptID;
            this.password = password;
            this.email = email;
        }


        // Getters and Setters //

        public string getReceiptID()
        {
            return receiptID;
        }

        public void getReceiptID(string value)
        {
            receiptID = value;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string value)
        {
            password = value;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string value)
        {
            email = value;
        }

    }
}