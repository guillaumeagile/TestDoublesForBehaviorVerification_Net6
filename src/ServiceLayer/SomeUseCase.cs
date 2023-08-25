using LanguageExt;

namespace src.ServiceLayer;

public class SomeUseCase
{
    //simulate DI if you need
    public SomeUseCase()
    {
        
    }
    
    public Option<int> GrabTheUsefullData()
    {
        return Option<int>.None;
        // instead of this, please read the value from ...
        // a "system" that can read from external dependencies (like a filesystem, a BD)
        
        // then you have to ASSUME that the data come into the proper format !!!
        // how can you manage that?
        
       // for a start, we check if we are *AT LEAST* able to return the expected value
       // return Option<int>.Some(4);
    }
}