document.addEventListener("DOMContentLoaded", function () {
  const registerBtn = document.getElementById("registerBtn");

  if (registerBtn) {
    registerBtn.addEventListener("click", function () {
      const name = document.getElementById("name").value;
      const age = document.getElementById("age").value;
      const color = document.getElementById("color").value;
      const gender = document.querySelector('input[name="gender"]:checked');

      if (!name) {
        alert("Please enter your name");
        return;
      }

      if (!age) {
        alert("Please enter your age");
        return;
      }

      if (!color) {
        alert("Please select a favorite color");
        return;
      }

      if (!gender) {
        alert("Please select a gender");
        return;
      }
      const userData = {
        name: name,
        age: age,
        color: color,
        gender: gender.value,
      };

      localStorage.setItem("userName", userData.name);
      localStorage.setItem("userAge", userData.age);
      localStorage.setItem("userColor", userData.color);
      localStorage.setItem("userGender", userData.gender);

      window.location.href = "registered.html";
    });
  }
});
