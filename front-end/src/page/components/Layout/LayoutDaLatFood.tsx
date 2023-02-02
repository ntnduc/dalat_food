import {Avatar, Badge, Breadcrumb, Layout, Menu, theme} from 'antd';
import React from 'react';
const {Header, Content, Footer} = Layout;
import './style/layout-style.scss';

import { ShoppingOutlined, UserOutlined } from '@ant-design/icons';

import LOGO from '../../../logo.svg';

const LayoutDaLatFood = () => {
    const {
        token: {colorBgContainer},
    } = theme.useToken();

    const onLogin = () => {
        console.log('login');
    };

    return (
        <Layout className='layout-dalat-food'>
            <Header style={{position: 'sticky', top: 0, zIndex: 1, width: '100%'}} className='custom-header'>
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
                            <ShoppingOutlined style={{fontSize: 30, opacity: 0.4}}/>
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
            <Content className="site-layout" style={{padding: '0 50px'}}>
                <div style={{padding: 24, minHeight: 380, background: colorBgContainer}}>Content</div>
            </Content>
            <Footer style={{textAlign: 'center'}}>Ant Design ©2023 Created by Ant UED</Footer>
        </Layout>
    );
};

export default LayoutDaLatFood;