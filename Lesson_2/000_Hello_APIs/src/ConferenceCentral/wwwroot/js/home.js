/*
 * Execute a request to the hello API
 */
function greetGenerically() {
  // Call the hello api.
  $.ajax("/api/hello/").done(helloCallback);
}

/*
 * Execute a request to the hello API.
 * Illustrates calling an API that takes an argument.
 */
function greetByName() {
  // Get the name from the name_field element
  var name = document.getElementById("name_field").value;

  // Call the hello api, passing in the name
  $.ajax("/api/hello/" + name).done(helloCallback);
}

// Process the JSON response
// In this case, just show an alert dialog box
// displaying the the response message
function helloCallback(message) {
  alert(message);
}
