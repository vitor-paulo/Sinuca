namespace Sinuca.Application.Interfaces
{
    public interface IEnvironmentVariables
    {
        string GetEnvironmentVariable(string variableName);
        void SetEnvironmentVariable(string variableName, string value);
    }
}
