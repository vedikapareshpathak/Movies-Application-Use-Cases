Classes and Methods : 

1. Movie Class :
Represents a movie and stores the details like ID, title, actor, actress, and year of release.

- Properties :
  - Id: Unique identifier for the movie.
  - Title: Title of the movie.
  - Actor: Lead actor in the movie.
  - Actress: Lead actress in the movie.
  - Year: Release year of the movie.


2. MovieCollection Class :
Manages movies organized by language using a nested dictionary.

- Methods:
  - AddMovie(string language, Movie movie): Adds a movie under the given language. If the language doesn’t exist, it creates a new category.
  - RemoveMovie(string language, Movie movie): Removes a movie from the specified language's collection if it exists. Returns a `bool` (true/false) to indicate success.
  - MovieCount(): Computes and returns the total number of movies across all languages.


3. MovieManager Class :
Provides a user-friendly interface for interacting with `MovieCollection` and manages real-time acknowledgments using a delegate.

- Methods:
  - AddMovie(Movie movie, string language): Adds a movie to the collection, then calls the `MovieAddAck` delegate to acknowledge the addition.
  - RemoveMovie(string language, Movie movie): Removes a movie from a particular language and logs whether the operation was successful.
  - MovieCount(): Displays the total count of movies across all languages.
  
- Delegate:
  - `MovieAddAck(string message): Acknowledges the successful addition of a movie through a custom or default method (e.g., logging to the console).

These classes and methods work together to provides movie management.
