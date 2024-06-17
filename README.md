# transformers-battle-sim

This project is partly a learning effort to re-teach myself ASP.NET MVC, as it has been many years since I had worked with it.

## Main Interfaces

**ICharacter** represents a character that can take part in a battle sim. To support code reuse on battle simulators, attributes not specific to a Transformer are part of ICharacter.

**ITransformer** inherits from ICharacter. Each instance of Transformer has a list of generic type **IMode** that can be populated with concrete implementations of different modes (robot, fighter jet, sports car, tank) that transformer can turn into. Different modes have different movement properties and a different attack power. 

**IRepository** is a logical abstraction of the functions to store and retrieve ICharacter objects from the data layer. While the concrete implementation **TransformerRepository** uses Microsoft Entity Framework and SQL, IRepository is generic enough that the classes that use it can be completely agnostic of the data layer implementation. 

## Future Implementation Ideas

- Due to time constraints, I was not able to implement the actual battle sim at all.
- I realized partway through that logically, Transformers have wildly varying robot modes from each other (Optimus Prime as a robot is very different from Starscream as a robot) so I probably should have included the robot mode attributes as part of the Transformer class itself rather than making it part of the List<IMode>
- It would be preferred for each mode to have more detailed information about the types of attacks a Transformer can perform in that mode (Like a list of moves on a Pokemon, but transforming to another mode gives you a different list of moves). Due to time constraints, I have given them a single attack stat to signify their damage output.
