import React, {useRef, useState} from 'react';
import menuIcon from './/menu.svg';
import classes from './Burger.module.css';

const Burger = (visibilty, params) => {
    return (
        <div className={classes.burgerMenu}>
            <img alt={'burger'} src={menuIcon}/>
        </div>
    );
};

export default Burger;