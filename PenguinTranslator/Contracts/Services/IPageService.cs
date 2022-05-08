using System;

namespace PenguinTranslator.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
