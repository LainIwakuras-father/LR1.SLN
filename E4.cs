namespace MyfirstApp
{
    internal class Laptop
    {
        public string Model { get; set; }
        public double CPU { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int Waight { get; set; }

        public string info
        {
            get
            {
                return $"Модель: {Model}, Процессор: {CPU} ГГц, ОЗУ: {RAM} ГБ, Жесткий диск: {HDD} ГБ, Масса: {Waight} кг ";
            }
        }

        public Laptop(string model, double cpu, int ram, int hdd, int waight)
        {
            Model = model;
            CPU = cpu;
            RAM = ram;
            HDD = hdd;
            Waight = waight;
        }
    }
}