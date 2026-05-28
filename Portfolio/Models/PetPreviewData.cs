public record PetPreviewData(string Name, List<string> Images, string Bio)
{
    public static readonly List<PetPreviewData> Pets =
    [
        new("Miklo",
        [
            "images/pets/miklo-first-day.jpeg",
            "images/pets/miklo-month-one-2.jpeg",
            "images/pets/miklo-month-three.jpeg",
            "images/pets/miklo-first-swim.jpeg",
            "images/pets/miklo-seal-pose.jpeg",
            "images/pets/miklo-akward-smile.jpeg",
        ], "This guy loves food. If you are eating something he will put his snout on your thigh and leave his slob all over so give him food before that happens! Miklo has two favorite hobbies going out on a walk and sleeping"),
        new("Polo",
        [
            "images/pets/polo-sock-thief.jpeg",
            "images/pets/polo-sleeping.jpeg",
            "images/pets/polo-looking-back.jpeg",
            "images/pets/polo-lying-down-tired.jpeg",
            "images/pets/polo-lying-down-wet.jpg",
        ], "This Chihuaha-Schnauzer looking guy also loves to eat. With his big ears, twisted tail, and beard, he looks like a gentleman but that he is not! This little guy refuses to be bullied by anyone no matter the size"),
        new("Capitan",
        [
            "images/pets/capi-first-week.jpeg",
            "images/pets/capi-with-miklo.jpeg",
            "images/pets/capi-miklo-at-park.jpeg",
            "images/pets/capi-ball-in-mouth.jpeg",
            "images/pets/capi-sofa-headrest.jpeg",
            "images/pets/capi-ate-bee.jpeg",
        ], "Will never leave your side if you have a ball. Absolutely loves fetch; if he could play fetch all day - he will take it! "),
    ];
}