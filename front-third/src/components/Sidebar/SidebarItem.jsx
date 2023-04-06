import React, {useEffect} from 'react';
import './Styles/SidebarItem.css';


const $ = require('jquery');

const SidebarItem = (props) => {

    useEffect(() => {
        $('.sub-btn').click(function(){
            $(this).next('.sub-menu').slideToggle();
        });
    });
    return props.items.isDropdown === true ?
        (
            <div className={"item"}>
                <a className={'sub-btn'}>
                    {props.items.name}
                </a>
                <div className={"sub-menu"}>
                    {props.items.dropItems.map((item) => {
                        <a key={item.id}>{item.text}</a>
                    })
                    }
                </div>
            </div>
        )
        :
        (
            <div className={"item"}>
                <a>
                    {props.items.name}
                </a>
            </div>
        );
};

export default SidebarItem;



