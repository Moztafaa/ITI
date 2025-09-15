function openTypingWindow() {
  // Open a new child window
  const childWindow = window.open('child.html', 'typingWindow', 'width=500,height=300,left=100,top=100');

  childWindow.onload = function () {
    startTypingEffect(childWindow);
  };
}

function startTypingEffect(childWindow) {
  const message = "Hello! This is a typing message effect. Watch as each character appears one by one...";
  const messageElement = childWindow.document.getElementById('typingMessage');
  let currentIndex = 0;

  messageElement.textContent = '';

  const typingInterval = setInterval(() => {
    if (currentIndex < message.length) {
      messageElement.textContent += message[currentIndex];
      currentIndex++;
    } else {
      clearInterval(typingInterval);
      setTimeout(() => {
        childWindow.close();
      }, 2000);
    }
  }, 50);
}
