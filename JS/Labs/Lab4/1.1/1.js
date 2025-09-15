// Minimal Child Window Control
let childWindow;
let interval;

function openChild() {
  if (childWindow && !childWindow.closed) return;

  childWindow = window.open('./child.html', '', 'width=200,height=100,alwaysRaised=yes');

  let y = 0;
  let direction = 1;
  interval = setInterval(() => {
    if (childWindow.closed) {
      clearInterval(interval);
      return;
    }
    y += direction * 20;
    if (y >= screen.height - 100 || y <= 0) direction *= -1;
    childWindow.moveTo(100, y);
  }, 50);
}

function closeChild() {
  clearInterval(interval);
  if (childWindow) {
    childWindow.close();
    childWindow = null;
  }
}
