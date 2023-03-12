import './App.css';
import React, {useState} from "react";
import {Header} from "antd/es/layout/layout";
import {Button, Menu, ConfigProvider, Radio, Checkbox} from "antd";
import MenuItem from "antd/es/menu/MenuItem";
import { AppstoreOutlined, MailOutlined, SettingOutlined } from '@ant-design/icons';
import LeftMenu from "./Components/LeftMenu";

const items = [
    {
        label: 'Navigation One',
        key: 'mail',
        icon: <MailOutlined />,
    },
    {
        label: 'Navigation Two',
        key: 'app',
        icon: <AppstoreOutlined />,
        disabled: true,
    },
    {
        label: 'Navigation Three - Submenu',
        key: 'SubMenu',
        icon: <SettingOutlined />,
        children: [
            {
                type: 'group',
                label: 'Item 1',
                children: [
                    {
                        label: 'Option 1',
                        key: 'setting:1',
                    },
                    {
                        label: 'Option 2',
                        key: 'setting:2',
                    },
                ],
            },
            {
                type: 'group',
                label: 'Item 2',
                children: [
                    {
                        label: 'Option 3',
                        key: 'setting:3',
                    },
                    {
                        label: 'Option 4',
                        key: 'setting:4',
                    },
                ],
            },
        ],
    },
    {
        label: (
            <a href="https:ant.design" target="_blank" rel="noopener noreferrer">
                Navigation Four - Link
            </a>
        ),
        key: 'alipay',
    }
];

const theme = {
    token: {
        colorPrimary: '#1890ff',
    },
};

function App() {
    return (
        <ConfigProvider
            theme={{
                token: {
                    colorPrimary: '#49277c',
                    colorPrimaryBg: '#d6d4d8'
                },
            }}>
            <div className={'header'}>
                    <div className={'nav-logo'}>
                        <a href={'#'} style={{textDecoration: 'none', whiteSpace: 'nowrap'}}>
                            <h1>
                                DOT-NET.AZ
                            </h1>
                        </a>
                    </div>
                    <Menu mode="horizontal" items={items} />
            </div>
                <LeftMenu/>
        </ConfigProvider>
    );
}



export default App;

