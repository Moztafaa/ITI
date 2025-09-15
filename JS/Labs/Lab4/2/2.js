function parseQueryString() {
  const params = {};
  const queryString = location.search.substring(1); // Remove the '?' at the beginning

  if (queryString) {
    const pairs = queryString.split('&');

    for (const element of pairs) {
      const pair = element.split('=');
      const key = decodeURIComponent(pair[0]);
      const value = decodeURIComponent(pair[1] || '');
      params[key] = value;
    }
  }

  return params;
}

const urlParams = parseQueryString();

const name = urlParams.name;
const title = urlParams.title;
const email = urlParams.email;
const mobile = urlParams.mobile;
const gender = urlParams.gender;
const address = urlParams.address;

document.getElementById('greeting').textContent = `Welcome ${title} ${name}!`;

document.getElementById('userName').textContent = name
document.getElementById('userTitle').textContent = title
document.getElementById('userEmail').textContent = email
document.getElementById('userMobile').textContent = mobile
document.getElementById('userGender').textContent = gender
document.getElementById('userAddress').textContent = address

const userAgent = navigator.userAgent.toLowerCase();
const isChrome = userAgent.includes('chrome');

if (!isChrome) {
  const browserRecommendation = document.getElementById('browserRecommendation');
  browserRecommendation.innerHTML =
    `<h3>Browser Recommendation</h3>
        <p>We recommend using Google Chrome for the best experience on our website.</p>`
  ;
}
