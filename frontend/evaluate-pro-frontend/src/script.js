const signupModal = document.querySelector(".signup-form-wrapper");
const loginModal = document.querySelector(".login-form-wrapper");
const signupBtn = document.querySelector(".signup-btn");
const loginBtn = document.querySelector(".login-btn");
const signupX = document.querySelector(".signup-x");
const loginX = document.querySelector(".login-x");
const formContainer = document.querySelector(".form-container");
const bodyE1 = document.querySelector("body");
const toggleE1 = document.querySelector(".fa-moon-o");

toggleE1.addEventListener("click", ()=>{
    bodyE1.classList.toggle("dark");

    if (bodyE1.classList.contains("dark")) {
        toggleE1.classList.replace("fa-moon-o","fa-sun-o")
    } else {
        toggleE1.classList.replace("fa-sun-o","fa-moon-o")
    }
});
// signupBtn.addEventListener("click", () => {
//   signupModal.classList.add("display");
//   formContainer.classList.add("disable");
// });

loginBtn.addEventListener("click", () => {
  loginModal.classList.add("display");
  formContainer.classList.add("disable");
});

// signupX.addEventListener("click", () => {
//   signupModal.classList.remove("display");
//   formContainer.classList.remove("disable");
// });

loginX.addEventListener("click", () => {
  loginModal.classList.remove("display");
  formContainer.classList.remove("disable");
});