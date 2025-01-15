# Article-Portal
### Project Overview
The Article Portal is a Blazor WebAssembly application designed to fetch and display articles from a remote API. The project includes components for listing articles, viewing article details, and basic error handling.
### Components and Files
#### Pages
ArticleList.razor :Fetches and displays a grid of articles.
                    Allows users to navigate to the article details page by clicking "Read More."
                    
ArticleDetail.razor :Fetches and displays details for a specific article
                      Provides a "Go Back" button for navigation.
Home.razor : Default landing page of the application.

Services
FetchDataServices.cs
- Contains methods to fetch article data from the remote API.
- GetArticlesAsync: Retrieves a list of articles.
- GetArticleByIdAsync: Retrieves a specific article by ID.

#### CSS Files

app.css: Global application-wide styles.

articledetail.css: Styles for the article detail component.

articlelist.css: Styles for the article list component.

#### Error Handling

Error Messages
- Failed to load articles. Please try again later.: Displays if the article list cannot be fetched.

- Failed to load the article. Please try again later.: Displays if a specific article cannot be fetched.

