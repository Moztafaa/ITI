window.onload = function () {
  let originalImg = document.querySelector("#header img");

  originalImg.onclick = function () {
    let img1 = document.createElement("img");
    img1.src = originalImg.src;
    img1.alt = originalImg.alt;

    img1.style.position = "fixed";
    img1.style.top = "10px";
    img1.style.right = "10px";
    img1.style.width = "100px";
    img1.style.height = "auto";

    let img2 = document.createElement("img");
    img2.src = originalImg.src;
    img2.alt = originalImg.alt;

    img2.style.position = "fixed";
    img2.style.bottom = "10px";
    img2.style.left = "10px";
    img2.style.width = "100px";
    img2.style.height = "auto";

    document.body.appendChild(img1);
    document.body.appendChild(img2);
    originalImg.style.visibility = "hidden";

    let navList = document.getElementById("nav");
    navList.style.listStyleType = "circle";
  };
};
