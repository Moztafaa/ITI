let Name = prompt("Enter your name: ");
// validate name (only characters and spaces)
let nameRegex = /^[a-zA-Z\s]+$/;
while (!nameRegex.test(Name) || Name.trim() === "") {
  alert("Please enter a valid name (only letters and spaces)!");
  Name = prompt("Enter your name: ");
}

let phone = prompt("Enter your phone number (8 digits): ");
let phoneRegex = /^\d{8}$/;
while (!phoneRegex.test(phone)) {
  alert("Please enter a valid phone number (8 digits)!");
  phone = prompt("Enter your phone number (8 digits): ");
}


let mobile = prompt("Enter your mobile number: ");
let mobileRegex = /^(010|011|012|015)\d{8}$/;
while (!mobileRegex.test(mobile)) {
  alert("Please enter a valid mobile number (starts with 010, 011, 012, or 015 followed by 8 digits)!");
  mobile = prompt("Enter your mobile number: ");
}

let email = prompt("Enter your email: ");
let emailRegex = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.com$/;
while (!emailRegex.test(email)) {
  alert("Please enter a valid email (e.g.,abc@123.com)!");
  email = prompt("Enter your email: ");
}

let color = prompt("Choose a color (red, green, or blue): ").toLowerCase();
while (!["red", "green", "blue"].includes(color)) {
  alert("Please choose a valid color: red, green, or blue!");
  color = prompt("Choose a color (red, green, or blue): ").toLowerCase();
}
let userInfo = `Welcome ${Name}!\nPhone: ${phone}\nMobile: ${mobile}\nEmail: ${email}}`;
let colorCodes = {
  red: "\x1b[31m",
  green: "\x1b[32m",
  blue: "\x1b[34m",
  reset: "\x1b[0m"
};
console.log(colorCodes[color] + userInfo + colorCodes.reset);
