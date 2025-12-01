namespace DesignPatterns.Builder._1;

public interface IComputerBuilder
{
    IComputerBuilder SetCpu(string cpu);

    IComputerBuilder SetRam(string ram);

    IComputerBuilder SetStorage(string storage);

    IComputerBuilder SetGpu(string gpu);

    Computer Build();
}