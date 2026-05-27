window.initRevealSections = () => {
    const sections = document.querySelectorAll('.reveal-section');

    if (!sections.length) return;

    const observer = new IntersectionObserver((entries) => {
        for (const entry of entries) {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
            } else {
              entry.target.classList.remove('visible');
            }
        }
    }, { threshold: 0.05 });

    sections.forEach(section => observer.observe(section));
};