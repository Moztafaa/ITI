window.onload = function () {
  let topImg = document.getElementById("topImg");
  let icon1 = document.getElementById("icon1");
  let icon2 = document.getElementById("icon2");
  let startBtn = document.getElementById("startBtn");
  let resetBtn = document.getElementById("resetBtn");

  let isMoving = false;
  let animationInterval;

  let topY = 250;
  let icon1X = 0;
  let icon2X = 450;

  let topDirection = -1;
  let icon1Direction = 1;
  let icon2Direction = -1;

  function setInitialPositions() {
    topImg.style.left = "225px";
    topImg.style.top = topY + "px";

    icon1.style.left = icon1X + "px";
    icon1.style.top = "125px";

    icon2.style.left = icon2X + "px";
    icon2.style.top = "125px";
  }

  function moveImages() {
    topY += topDirection * 2;
    if (topY <= 0 || topY >= 250) {
      topDirection *= -1;
    }
    topImg.style.top = topY + "px";

    icon1X += icon1Direction * 2;
    if (icon1X <= 0 || icon1X >= 450) {
      icon1Direction *= -1;
    }
    icon1.style.left = icon1X + "px";

    icon2X += icon2Direction * 2;
    if (icon2X <= 0 || icon2X >= 450) {
      icon2Direction *= -1;
    }
    icon2.style.left = icon2X + "px";
  }

  startBtn.onclick = function () {
    if (!isMoving) {
      isMoving = true;
      startBtn.innerHTML = "Stop";
      animationInterval = setInterval(moveImages, 0);
    } else {
      isMoving = false;
      startBtn.innerHTML = "Start";
      clearInterval(animationInterval);
    }
  };

  resetBtn.onclick = function () {
    if (isMoving) {
      isMoving = false;
      startBtn.innerHTML = "Start";
      clearInterval(animationInterval);
    }

    topY = 250;
    icon1X = 0;
    icon2X = 450;

    topDirection = -1;
    icon1Direction = 1;
    icon2Direction = -1;

    setInitialPositions();
  };

  setInitialPositions();
};
