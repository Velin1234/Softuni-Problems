function HeroicInventory(heroArr) {
    let heroes = [];
    for(let hero of heroArr) {
        let [name, level, items] = hero.split(' / ');
        const newHero = {
            name,
            level: Number(level),
            items: items ? items.split(', ') : []
        }
        heroes.push(newHero);
    }
    console.log(JSON.stringify(heroes));
}

HeroicInventory(['Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']);