import React from 'react';
import SidebarItem from "./SidebarItem";
import './Styles/Sidebar.css';
const Sidebar = () => {

    const items = {
        first: {
            name: 'First',
            isDropdown: false
        },
        second: {
            name: 'Second',
            isDropdown: false
        },
        third: {
            name: 'Third',
            isDropdown: true,
            dropItems: [
                {
                    id: 1,
                    text: 'First'
                },
                {
                    id: 2,
                    text: 'Second'
                },
                {
                    id: 3,
                    text: 'Third'
                }
            ]
        }
    }
    return (
        <div className={'side-bar'}>
            <SidebarItem items={items.first} />
            <SidebarItem items={items.second}/>
            <SidebarItem items={items.third}/>
        </div>
    );
};

export default Sidebar;