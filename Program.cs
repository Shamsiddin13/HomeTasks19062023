using HomeTask19_06_2023;

ComputerStore<Guid, string, float> computerStore = new ComputerStore<Guid, string, float>(Guid.NewGuid(), "HP", 500.0f);
computerStore.GetInfo();

ComputerStore<Guid, string, float> LaptopStore = new ComputerStore<Guid, string, float>(Guid.NewGuid(), "ASUS", 700.0f);
LaptopStore.GetInfo();

ComputerService<int, string> computerService = new ComputerService<int, string>(32, "256M2SSD");
computerService.GetServiceInfo();


