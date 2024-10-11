namespace MyfirstApp
{
    internal class Smartphone
    {
        public string Model { get; set; }
        public double CPU { get; set; }
        public int RAM { get; set; }
        public int PM { get; set; }
        public string OS { get; set; }
        public int Waight { get; set; }
        public string info
        {
            get
            {
                return $"Модель: {Model}, Процессор: {CPU} ГГц, ОЗУ: {RAM} ГБ, Постоянная память: {PM} ГБ, Операционная система: {OS} ,Масса: {Waight}";
            }
        }

        public Smartphone(string model, double cpu, int ram, int pm, string os, int waight)
        {
            Model = model;
            CPU = cpu;
            RAM = ram;
            PM = pm;
            OS = os;
            Waight = waight;
        }
    }
}