const navLinks = document.querySelectorAll(".nav-links a");
navLinks.forEach(function (link) {
  link.addEventListener("click", function (event) {
    const sectionId = link.getAttribute("href");
    if (sectionId && sectionId.startsWith("#")) {
      const section = document.querySelector(sectionId);

      if (section) {
        event.preventDefault();

        section.scrollIntoView({
          behavior: "smooth",
        });
      }
    }
  });
});
const heroLinks = document.querySelectorAll(".hero-buttons a");
heroLinks.forEach(function (link) {
  link.addEventListener("click", function (event) {
    const sectionId = link.getAttribute("href");
    if (sectionId && sectionId.startsWith("#")) {
      const section = document.querySelector(sectionId);

      if (section) {
        event.preventDefault();

        section.scrollIntoView({
          behavior: "smooth",
        });
      }
    }
  });
});
window.addEventListener("scroll", function () {
  const header = document.querySelector("header");
  if (header) {
    if (window.scrollY > 50) {
      header.classList.add("scrolled");
    } else {
      header.classList.remove("scrolled");
    }
  }
});
const menuButton = document.querySelector(".menu-button");
const navigation = document.querySelector(".nav-links");
if (menuButton && navigation) {
  menuButton.addEventListener("click", function () {
    navigation.classList.toggle("show-menu");
  });
}
