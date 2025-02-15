

    public interface ISubject
    {
        string Request();
    }

    public class Subject
    {
        public string Request()
        {
            return "Subject Request" + "Choose left door\n";
        }
    }

    public class Proxy : ISubject
    {
        Subject subject;

        public string Request()
        {
            if (subject == null)
            {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }
            Console.WriteLine("Subject active");
            return "Proxy: Call to " + subject.Request();
        }

        public class ProtectionProxy : ISubject
        {
            Subject subject;
            private string password = "Avakadabra";

            public string Authenticate(string supplied)
            {
                if(supplied != password)
                {
                    return "Protection Proxy: No access";
                }
                else
                {
                    subject = new Subject();
                    return "Protection Proxy: Authenticated";
                }
            }

            public string Request()
            {
                if(subject == null)
                {
                    return "Protection Proxy: Authenticate first";
                }
                else
                {
                    return "Protection Proxy: Call to " + subject.Request();
                }
            }
        }
    }