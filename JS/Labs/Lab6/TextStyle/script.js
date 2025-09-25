let paragraph = document.getElementById("PAR");

window.onload = function () {
  let fontRadios = document.getElementsByName("Font");
  for (const element of fontRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeFont(this.value);
      }
    });
  }

  let alignRadios = document.getElementsByName("Align");
  for (const element of alignRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeAlign(this.value);
      }
    });
  }

  let heightRadios = document.getElementsByName("Height");
  for (const element of heightRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeHeight(this.value);
      }
    });
  }

  let lspaceRadios = document.getElementsByName("Lspace");
  for (const element of lspaceRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeLSpace(this.value);
      }
    });
  }

  let indentRadios = document.getElementsByName("Indent");
  for (const element of indentRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeIndent(this.value);
      }
    });
  }

  let transformRadios = document.getElementsByName("Transform");
  for (const element of transformRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeTransform(this.value);
      }
    });
  }

  let decorateRadios = document.getElementsByName("Decorate");
  for (const element of decorateRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeDecorate(this.value);
      }
    });
  }

  let borderRadios = document.getElementsByName("Border");
  for (const element of borderRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeBorder(this.value);
      }
    });
  }

  let borderColorRadios = document.getElementsByName("BorderColor");
  for (const element of borderColorRadios) {
    element.addEventListener("change", function () {
      if (this.checked) {
        ChangeBorderColor(this.value);
      }
    });
  }
};

// Functions to change styles

function ChangeFont(fontName) {
  paragraph.style.fontFamily = fontName;
}

function ChangeAlign(alignment) {
  paragraph.style.textAlign = alignment;
}

function ChangeHeight(height) {
  paragraph.style.lineHeight = height;
}

function ChangeLSpace(spacing) {
  paragraph.style.letterSpacing = spacing;
}

function ChangeIndent(indent) {
  paragraph.style.textIndent = indent;
}

function ChangeTransform(transform) {
  paragraph.style.textTransform = transform;
}

function ChangeDecorate(decoration) {
  paragraph.style.textDecoration = decoration;
}

function ChangeBorder(borderStyle) {
  if (borderStyle === "none") {
    paragraph.style.border = "none";
  } else {
    paragraph.style.borderStyle = borderStyle;
    paragraph.style.borderWidth = "2px";
  }
}

function ChangeBorderColor(color) {
  paragraph.style.borderColor = color;
  if (
    paragraph.style.border === "none" ||
    paragraph.style.borderStyle === "none"
  ) {
    paragraph.style.borderStyle = "solid";
    paragraph.style.borderWidth = "2px";
  }
}
