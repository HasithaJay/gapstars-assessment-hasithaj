# Chinook

This application is unfinished. Please complete below tasks. Spend max 2 hours.
We would like to have a short written explanation of the changes you made.

1. Move data retrieval methods to separate class / classes (use dependency injection)
2. Favorite / unfavorite tracks. An automatic playlist should be created named "My favorite tracks"
3. The user's playlists should be listed in the left navbar. If a playlist is added (or modified), this should reflect in the left navbar (NavMenu.razor). Preferrably, the left menu should be refreshed without a full page reload.
4. Add tracks to a playlist (existing or new one). The dialog is already created but not yet finished.
5. Search for artist name

When creating a user account, you will see this:
"This app does not currently have a real email sender registered, see these docs for how to configure a real email sender. Normally this would be emailed: Click here to confirm your account."
After you click 'Click here to confirm your account' you should be able to login.

Please put the code in Github. Please put the original code (our code) in the master branch, put your code in a separate branch, and make a pull request to the master branch.


# Changes made:

1. **Reorganized Repositories:** Grouped related units and established repositories/interfaces in the `Repositories` folder for efficient data retrieval methods.

2. **Dependency Injection Setup:** All repositories have been registered using the `DependencyManager/DependencyInjection` class and added as services in `Program.cs`.

3. **Applied Dependency Injection:** Implemented dependency injection in relevant `.razor` pages, enhancing modularity and maintainability.

4. **Data Mappings:** Introduced data mappings in the `ClientMapping` folder, ensuring effective translation between data layers.

5. **Favorite/Unfavorite Functionality:** Implemented favorite/unfavorite actions using the `PlaylistRepository` class and updated associated razor pages.

6. **User's Playlists Display:** Displaying user playlists on the left navigation bar through the enhanced `Index.razor` page.

7. **Search Capability:** Search functionality implemented in the `Index.razor` page.
