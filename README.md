## About Projects

- No special architecture was used in the project. Entities are simply created and HTTP requests are made from the controller.
- In outline; Task adding, deleting and updating operations are available. The deletion process was added as a soft delete so that it would not be deleted from the database, and this information was kept with the IsDeleted entity property.
- Task color changes have been applied for completed and in progress states. These can be easily changed via style.css.

#### Screenshot of the project
![todo_list_screenshot](https://github.com/alicansariboga/ToDoList/assets/23722313/757b7d43-eeee-4f7a-b487-988121c12597)

After adding your own SQL server connection to the BaseDbContex file in the data, you can use the project with the add-migration "migration_name" and update-migration commands.
I wish everyone good luck.

You can contact and connect with me <a>[LinkedIn](https://www.linkedin.com/in/alicansariboga/)<a/> or <b><a href="mailto:alicansariboga1@gmail.com" target="blank">E-Mail</a></b>.
