namespace MyfirstApp
{
    internal class Post
    {
        public string Index { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Frame { get; set; }
        public string Apartment { get; set; }
        public string Message { get; set; }
        public string Address
        {
            get
            {
                string address = $"{Index}, {City}, {Street}, {House}";
                if (!string.IsNullOrWhiteSpace(Frame))
                {
                    address += $", корпус {Index}";
                }
                if (!string.IsNullOrWhiteSpace(Apartment))
                {
                    address += $", кв. {Apartment}";
                }
                return address;
            }
        }

        public Post(string index, string city, string street, string house, string frame, string apartment, string message)
        {
            Index = index;
            City = city;
            Street = street;
            House = house;
            Frame = frame;
            Apartment = apartment;
            Message = message;
        }
        public bool Valid()
        {
            // Проверяем, что обязательные поля не пустые
            if (string.IsNullOrWhiteSpace(Index) ||
                string.IsNullOrWhiteSpace(City) ||
                string.IsNullOrWhiteSpace(Street) ||
                string.IsNullOrWhiteSpace(House) ||
                string.IsNullOrWhiteSpace(Message))
            {
                return false;
            }
            return true;
        }
    }
}