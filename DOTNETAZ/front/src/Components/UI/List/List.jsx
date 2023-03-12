import React, {useState} from 'react';
import classes from './List.module.css';

const List = ({items, props}) =>
{
    const [isActive, setIsActive] = useState(false);
    const dropDownToggler = event => {
        setIsActive(current => !current);
    }

    const renderList = items.map(item =>
        <li key={item.id}>
            <a href='#' className={classes.listItem}>
                {item.name}
            </a>
        </li>
    );

    return (
        <ul className={classes.navbarList}>
            {renderList}
            <li>
                <a onClick={dropDownToggler} className={classes.listItem}>
                    Dropdown
                    <ul className={isActive ? classes.dropList : classes.dropList}>
                        <li>First</li>
                        <li>Second</li>
                        <li>Third</li>
                    </ul>
                </a>
            </li>
        </ul>
    );
}

export default List;