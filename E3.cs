namespace MyfirstApp
{
    internal class Computer
    {
        public string Model { get; set; }
        public double CPU { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }



        public string info
        {
            get
            {
                return $"Модель: {Model}, Процессор: {CPU} ГГц, ОЗУ: {RAM} ГБ, Жесткий диск: {HDD} ГБ";
            }
        }

        public Computer(string model, double cpu, int ram, int hdd)
        {
            Model = model;
            CPU = cpu;
            RAM = ram;
            HDD = hdd;
        }

    }
}