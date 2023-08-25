using LanguageExt;

namespace src.ServiceLayer;

public class SomeUseCase
{
    //simulate DI if you need
    public SomeUseCase()
    {
        
    }
    
    public Option<int> KnowTheLargeurCarte()
    {
        //instead of this, please read the value from the map.json file (or mock it)
        return Option<int>.None;
    }
}