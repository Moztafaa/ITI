let users = [];

const tabsContainer = document.getElementById("tabsContainer");
const postsList = document.getElementById("postsList");
const postsTitle = document.getElementById("postsTitle");

async function fetchUsers() {
  fetch("https://jsonplaceholder.typicode.com/users")
    .then((response) => {
      return response.json();
    })
    .then((data) => {
      users = data;
      createUserTabs();
    })
    .catch((error) => {
      console.error("Error fetching users:", error);
      tabsContainer.innerHTML = "<h1>Error loading users.</h1>";
    });
}

async function createUserTabs() {
  tabsContainer.innerHTML = "";

  users.forEach((user) => {
    const tab = document.createElement("button");
    tab.className = "tab";
    tab.textContent = user.name;
    tab.dataset.userId = user.id;

    tab.addEventListener("click", () => handleTabClick(tab, user));

    tabsContainer.appendChild(tab);
  });
}

function handleTabClick(clickedTab, user) {
  document.querySelectorAll(".tab").forEach((tab) => {
    tab.classList.remove("active");
  });

  clickedTab.classList.add("active");

  postsTitle.innerHTML = `<h3>Posts by ${user.name}</h3>`;

  fetchUserPosts(user.id);
}

async function fetchUserPosts(userId) {
  try {
    const response = await fetch(
      `https://jsonplaceholder.typicode.com/posts?userId=${userId}`
    );

    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    const posts = await response.json();
    displayPosts(posts);
  } catch (error) {
    console.error("Error fetching posts:", error);
    postsList.innerHTML =
      '<li class="loading">Error loading posts. Please try again later.</li>';
  }
}

function displayPosts(posts) {
  postsList.innerHTML = "";

  if (posts.length === 0) {
    postsList.innerHTML = "<li>No posts found for this user.</li>";
    return;
  }

  posts.forEach((post) => {
    const listItem = document.createElement("li");
    listItem.textContent = post.title;
    postsList.appendChild(listItem);
  });
}

document.addEventListener("DOMContentLoaded", () => {
  fetchUsers();
});
