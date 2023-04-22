import './style/layout-style.scss';

import { Avatar, Badge, Layout, Menu, MenuProps, theme } from 'antd';
import React from 'react';
const { Header, Content } = Layout;

import { LaptopOutlined, ShoppingOutlined, UserOutlined } from '@ant-design/icons';
import Sider from 'antd/es/layout/Sider';
import AdminPage from 'page/AdminPage/AdminPage';
import { BrowserRouter, Link, NavLink, Route, Switch } from 'react-router-dom';

import LOGO from '../../logo.svg';
import ProductList from '../ProductPage/ProductList/ProductList';

const LayoutDaLatFood = () => {
    const {
        token: { colorBgContainer },
    } = theme.useToken();

    const onLogin = () => {
        console.log('login');
    };

    const handleMenu = (): MenuProps['items'] => {

        return [];
    };

    const itemMenu: MenuProps['items'] = [{
        key: '/product',
        icon: React.createElement(UserOutlined),
        label: (
            <Link to='/product' key={1}>
                Product
            </Link>
        )
    }, {
        key: '/admin',
        icon: React.createElement(LaptopOutlined),
        label: (
            <Link to='/admin' key={2}>
                Admin
            </Link>
        )
    }
    ];

    return (
        <Layout className='layout-dalat-food'>
            <Header style={{ position: 'sticky', top: 0, zIndex: 1, width: '100%' }} className='custom-header'>
                <div
                    style={{
                        float: 'left',
                        width: 120,
                        height: 31,
                        margin: '16px 24px 16px 0',
                        background: 'rgba(255, 255, 255, 0.2)',
                    }}
                />
                <div className='logo'>
                    <img src={LOGO} alt="Da Lat Food Logo" />
                </div>
                <div className='content-right'>
                    <div className='user-cart'>
                        <Badge count={2} className='user-cart-count'>
                            <ShoppingOutlined style={{ fontSize: 30, opacity: 0.4 }} />
                        </Badge>
                        Giỏ Hàng
                    </div>
                    <div className='user-login' onClick={onLogin}>
                        <Avatar className='avatar-user'
                            size={30}
                            icon={<UserOutlined />} />
                        Đăng Nhập
                    </div>
                </div>

            </Header>

            <Layout className='site-layout' style={{ padding: '24px 0', background: colorBgContainer }}>
                <Sider style={{ background: colorBgContainer }} width={200}>
                    <Menu
                        mode="inline"
                        defaultSelectedKeys={['/product']}
                        style={{ height: '100%' }}
                        items={itemMenu}
                    />
                </Sider>
                <Content style={{ padding: '0 24px', minHeight: 280 }}>
                    <Switch>
                        <Route path={'/product'} component={ProductList} />
                        <Route path={'/admin'} component={AdminPage} />
                    </Switch>
                </Content>
            </Layout>
            {/* <Content className="site-layout" >
                <div style={{padding: 24, minHeight: 380, background: colorBgContainer}}>Content</div>
            </Content> */}
            {/* <Footer style={{textAlign: 'center'}}>Ant Design ©2023 Created by Ant UED</Footer> */}
        </Layout>
    );
};

export default LayoutDaLatFood;