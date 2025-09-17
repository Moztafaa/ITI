let currentImageIndex = 1;
const totalImages = 6;
let slideshowIntervalId;
let isSlideShowRunning = false;
const slideImage = document.getElementById("slide");
const nextButton = document.getElementById("next");
const previousButton = document.getElementById("previous");
const slideshowButton = document.getElementById("slideshow");
const stopButton = document.getElementById("stop");
function updateImage() {
    slideImage.src = `Images/${currentImageIndex}.jpg`;
}
function nextImage() {
    currentImageIndex++;
    if (currentImageIndex > totalImages) {
        currentImageIndex = 6;
    }
    updateImage();
}
function previousImage() {
    currentImageIndex--;
    if (currentImageIndex < 1) {
        currentImageIndex = 1;
    }
    updateImage();
}
function nextImageForSlide() {
    currentImageIndex++;
    if (currentImageIndex > totalImages) {
        currentImageIndex = 1;
    }
    updateImage();
}
function startSlideshow() {
    if (!isSlideShowRunning) {
        isSlideShowRunning = true;
        slideshowIntervalId = setInterval(nextImageForSlide, 1000);
    }
}
function stopSlideshow() {
    if (isSlideShowRunning) {
        isSlideShowRunning = false;
        clearInterval(slideshowIntervalId);
    }
}
nextButton.addEventListener("click", nextImage);
previousButton.addEventListener("click", previousImage);
slideshowButton.addEventListener("click", startSlideshow);
stopButton.addEventListener("click", stopSlideshow);
updateImage();
