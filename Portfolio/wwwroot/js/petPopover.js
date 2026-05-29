window.calculatePopoverPosition = (mouseX, mouseY, modalWidth, modalHeight) => {
  console.log({
    mouseX, mouseY, modalWidth, modalHeight, windowW: window.innerWidth, windowH: window.innerHeight
  });

  const padding = 8;
  const viewportWidth = window.innerWidth;
  const viewportHeight = window.innerHeight;

  let left = mouseX + padding;
  let top = mouseY + padding;

  // Flip left if overflowing on the right
  if (left + modalWidth > viewportWidth) {
    left = viewportWidth - modalWidth - padding;
    if (left < 0) left = padding;
  }
  // Flip up if overflowing on the bottom
  if (top + modalHeight > viewportHeight) {
    top = mouseY - modalHeight - padding;
    if (top < 0) top = padding;
  }
  return { left, top };
};