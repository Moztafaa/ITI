let imgs = document.getElementsByTagName('img')
let imgIndex = 0;

function changeImage() {
  imgs[imgIndex].src = 'marbelsImages/marble3.jpg';

  setTimeout(() => {
    imgs[imgIndex].src = 'marbelsImages/marble1.jpg';
    imgIndex = (imgIndex + 1) % imgs.length;
  }, 500);
}

let intervalId = setInterval(changeImage, 1000);

for (const element of imgs) {
  element.addEventListener('mouseover', () => {
    clearInterval(intervalId);
  });
  element.addEventListener('mouseout', () => {
    intervalId = setInterval(changeImage, 1000);
  });
}

